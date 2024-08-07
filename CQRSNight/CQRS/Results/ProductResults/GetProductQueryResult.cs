﻿namespace CQRSNight.CQRS.Results.Product;

public class GetProductQueryResult
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
