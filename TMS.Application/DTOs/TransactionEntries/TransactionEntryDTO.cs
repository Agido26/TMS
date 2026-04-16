using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Application.DTOs.Transactions;
using TMS.Domain.Enums.TransactionEntries;

namespace TMS.Application.DTOs.TransactionEntries
{
    public class TransactionEntryDTO
    {
        public int Id { get; set; }
        public EntryType EntryType { get; set; }

        //TODO: change this with account object
        public int AccountID { get; set; }
        public TransactionDTO Transaction { get; set; } = new TransactionDTO();

    }
}
