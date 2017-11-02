using FluentValidator;
using ModernStore.Share.Commands;
using MordenStore.Domain.CommandResults;
using MordenStore.Domain.Commands;
using MordenStore.Domain.Entities;
using MordenStore.Domain.Repositories;
using MordenStore.Domain.Resources;
using MordenStore.Domain.Services;
using MordenStore.Domain.ValueObject;
using System;

namespace MordenStore.Domain.CommandHandlers
{
    public class CustomerCommandHandler : Notifiable, ICommandHandler<RegisterCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailService _emailService;

        public CustomerCommandHandler(ICustomerRepository customerRepository, IEmailService emailService)
        {
            _customerRepository = customerRepository;
            _emailService = emailService;
        }

        public ICommandResult Handle(RegisterCustomerCommand command)
        {
            // Passo1. Verificar se o CPF já existe
            if (_customerRepository.DocumentExist(command.Document))
            {
                AddNotification("Document", "CPF já em uso");
                return null;
            }

            // Passo2. Gerar o novo cliente
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);
            var user = new User(command.UserName, command.Password, command.ConfirmPassword);
            var customer = new Customer(user, name, document, email, null);

            // Passo3. Adicionar as notificações
            AddNotifications(name.Notifications);
            AddNotifications(document.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(user.Notifications);
            AddNotifications(customer.Notifications);

            // Passo4. Inserir no banco
            if (IsValid())
            {
                _customerRepository.Save(customer);
            }

            // Passo5. Enviar E-mail de boas vindas 
            _emailService.Send(
                customer.Name.ToString(),
                customer.Email.EmailAdress,
                string.Format(EmailTenplates.WelcomeEmailTitle,customer.Name.ToString()),
                string.Format(EmailTenplates.WelcomeEmailBody, customer.Name.ToString()));

            // Passo6. Retornar algo
            return new RegisterCustomerCommandResult(customer.Id, customer.Name.ToString());
        }
    }
}
