using Wincubate.StrategyExamples;

Func<Order, decimal> normalBillingStrategy = order => order.SuggestedSubtotal;
Func<Order, decimal> studentBillingStrategy = order =>
    (order.Product is Beer ?
        order.SuggestedSubtotal - (order.Count * 5) :
        order.SuggestedSubtotal);
Func<Order, decimal> regularBillingStrategy = order => 0.9m * order.SuggestedSubtotal;

Customer customer = new(normalBillingStrategy);

customer.PlaceOrder(new Order
(
    1,
    new Peanuts()
));

customer.PlaceOrder(new Order
(
    3,
    new Beer()
));

customer.PlaceOrder(new Order
(
    2,
    new PepsiMax()
));

customer.Tab.Print();
