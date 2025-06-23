using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Educate.SOLID.Solid2
{

    //Пример с нарушением принципа 
    public class TransactionError
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public DateTime ReceivMessage { get; set; }

        public void SendTransaction()
        {

            // Логика отправки сообщения об ошибке транзакции
            Console.WriteLine($"Отправка сообщения об ошибке: {Code} - {Message}");
        }


        public void GetTransaction()
        {
            // Логика получения информации о транзакции
            Console.WriteLine($"Получение информации о транзакции: {Code} - {Message}");
        }


        public void SendEmailInfo()
        {
            // Логика отправки email с информацией о транзакции
            Console.WriteLine($"Отправка email с информацией о транзакции: {Code} - {Message}");
        }

        public void GetEmailInfo()
        {
            // Логика получения информации из email
            Console.WriteLine($"Получение информации из email: {Code} - {Message}");
        }

        public void SendSmsInfo()
        {
            // Логика отправки SMS с информацией о транзакции
            Console.WriteLine($"Отправка SMS с информацией о транзакции: {Code} - {Message}");
        }

    }

    public class TransactionErrorRefactored
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public DateTime ReceivMessage { get; set; }
    }

    public class TransactionService
    {
               private readonly TransactionErrorRefactored _transactionError;
        public TransactionService(TransactionErrorRefactored transactionError)
        {
            _transactionError = transactionError;
        }
        public void SendTransaction()
        {
            // Логика отправки сообщения об ошибке транзакции
            Console.WriteLine($"Отправка сообщения об ошибке: {_transactionError.Code} - {_transactionError.Message}");
        }
        public void GetTransaction()
        {
            // Логика получения информации о транзакции
            Console.WriteLine($"Получение информации о транзакции: {_transactionError.Code} - {_transactionError.Message}");
        }
    }


    public class PostaService
    {
        private readonly TransactionErrorRefactored _transactionError;
        public PostaService(TransactionErrorRefactored transactionError)
        {
            _transactionError = transactionError;
        }
        public void SendEmailInfo()
        {
            // Логика отправки email с информацией о транзакции
            Console.WriteLine($"Отправка email с информацией о транзакции: {_transactionError.Code} - {_transactionError.Message}");
        }
        public void GetEmailInfo()
        {
            // Логика получения информации из email
            Console.WriteLine($"Получение информации из email: {_transactionError.Code} - {_transactionError.Message}");
        }
    }


}


