using System;

namespace Facade.Task1.OrderPlacement
{
    public class OrderFacade
    {
        private InvoiceSystem _invoiceSystem;
        private PaymentSystem _paymentSystem;
        private ProductCatalog _productCatalog;

        public OrderFacade(InvoiceSystem invoiceSystem, PaymentSystem paymentSystem, ProductCatalog productCatalog)
        {
            _invoiceSystem = invoiceSystem;
            _paymentSystem = paymentSystem;
            _productCatalog = productCatalog;
        }

        public void PlaceOrder(string productId, int quantity, string email)
		{
			var product = _productCatalog.GetProductDetails(productId);

			_paymentSystem.MakePayment(new Payment
			{
				ProductId = productId,
				ProductName = product.Name,
				Quantity = quantity,
				TotalPrice = product.Price
			});

			_invoiceSystem.SendInvoice(new Invoice
			{
				ProductId = productId,
				ProductName = product.Name,
				Quantity = quantity,
				TotalPrice = product.Price,
				CustomerEmail = email
			});
		}
    }
}
