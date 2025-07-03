using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Repositories
{
    public class InvoiceItemRepository
    {
        public List<InvoiceItems> GetByInvoiceId(int invoiceId)
        {
            using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
            {
                return context.InvoiceItems
                    .Where(ii => ii.InvoiceID == invoiceId)
                    .ToList();
            }
        }
    }
}
