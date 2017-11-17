using System;
using System.Collections.Generic;
using  Library.Domain.Core.Commands;

namespace  Library.Service.Inventory.Domain
{
    public class ImportBookInventoryCommand : CommonCommand
    {
        private static string ImportBookInventoryCommandKey = "Command_ImportBookInventory";

        public ImportBookInventoryCommand() : base(ImportBookInventoryCommandKey)
        {

        }

        public Guid BookId { get; set; }

        public List<Guid> BookInventoryIds { get; set; }
    }
}