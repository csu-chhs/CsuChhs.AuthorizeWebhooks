namespace CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.ResponseModels;

public class GetTransactionDetailsResponse
{
    public string? Xmlns { get; set; }
    public string? XmlnsXsd { get; set; }
    public string? XmlnsXsi { get; set; }
    public Messages? Messages { get; set; }
    public Transaction? Transaction { get; set; }
}

public class Messages
{
    public string? ResultCode { get; set; }
    public List<Message>? Message { get; set; }
}

public class Message
{
    public string? Code { get; set; }
    public string? Text { get; set; }
}

public class Transaction
{
    public string? TransId { get; set; }
    public string? RefTransId { get; set; }
    public string? SplitTenderId { get; set; }
    public DateTime? SubmitTimeUTC { get; set; }
    public DateTime? SubmitTimeLocal { get; set; }
    public string? TransactionType { get; set; }
    public string? TransactionStatus { get; set; }
    public int? ResponseCode { get; set; }
    public int? ResponseReasonCode { get; set; }
    public string? ResponseReasonDescription { get; set; }
    public string? AuthCode { get; set; }
    public string? AVSResponse { get; set; }
    public string? CardCodeResponse { get; set; }
    public string? CAVVResponse { get; set; }
    public string? FDSFilterAction { get; set; }
    public FDSFilters? FDSFilters { get; set; }
    public Batch? Batch { get; set; }
    public Order? Order { get; set; }
    public string? RequestedAmount { get; set; }
    public double? AuthAmount { get; set; }
    public double? SettleAmount { get; set; }
    public Tax? Tax { get; set; }
    public Shipping? Shipping { get; set; }
    public Duty? Duty { get; set; }
    public LineItems? LineItems { get; set; }
    public string? PrepaidBalanceRemaining { get; set; }
    public bool? TaxExempt { get; set; }
    public Payment? Payment { get; set; }
    public Customer? Customer { get; set; }
    public BillTo? BillTo { get; set; }
    public ShipTo? ShipTo { get; set; }
    public bool? RecurringBilling { get; set; }
    public string? CustomerIP { get; set; }
    public Subscription? Subscription { get; set; }
    public Profile? Profile { get; set; }
    public string? NetworkTransId { get; set; }
    public string? OriginalNetworkTransId { get; set; }
    public string? OriginalAuthAmount { get; set; }
    public string? AuthorizationIndicator { get; set; }
}

public class FDSFilters
{
    public List<FDSFilter>? FDSFilter { get; set; }
}

public class FDSFilter
{
    public string? Name { get; set; }
    public string? Action { get; set; }
}

public class Batch
{
    public string? BatchId { get; set; }
    public DateTime? SettlementTimeUTC { get; set; }
    public DateTime? SettlementTimeLocal { get; set; }
    public string? SettlementState { get; set; }
}

public class Order
{
    public string? InvoiceNumber { get; set; }
    public string? Description { get; set; }
    public string? PurchaseOrderNumber { get; set; }
}

public class Tax
{
    public string? Amount { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

public class Shipping
{
    public string? Amount { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

public class Duty
{
    public string? Amount { get; set; }
}

public class LineItems
{
    public List<LineItem>? LineItem { get; set; }
}

public class LineItem
{
    public string? ItemId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Quantity { get; set; }
    public string? UnitPrice { get; set; }
    public string? Taxable { get; set; }
}

public class Payment
{
    public CreditCard? CreditCard { get; set; }
}

public class CreditCard
{
    public string? CardNumber { get; set; }
    public string? ExpirationDate { get; set; }
    public string? CardType { get; set; }
}

public class Customer
{
    public string? Type { get; set; }
    public string? Id { get; set; }
    public string? Email { get; set; }
}

public class BillTo
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Country { get; set; }
    public string? PhoneNumber { get; set; }
}

public class ShipTo
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Country { get; set; }
}

public class Subscription
{
    public string? Id { get; set; }
    public string? PayNum { get; set; }
    public string? MarketType { get; set; }
    public string? Product { get; set; }
    public ReturnedItems? ReturnedItems { get; set; }
    public Solution? Solution { get; set; }
    public string? MobileDeviceId { get; set; }
}

public class ReturnedItems
{
    public ReturnedItem? ReturnedItem { get; set; }
}

public class ReturnedItem
{
    public string? Id { get; set; }
    public DateTime? DateUTC { get; set; }
    public DateTime? DateLocal { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
}

public class Solution
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? VendorName { get; set; }
}

public class Profile
{
    public string? CustomerProfileId { get; set; }
    public string? CustomerPaymentProfileId { get; set; }
}