using Wincubate.StrategyExamples;

Customer customer = new(Billing.Normal);

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
