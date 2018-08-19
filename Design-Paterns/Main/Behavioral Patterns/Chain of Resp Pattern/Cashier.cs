
namespace Main.Behavioral_Patterns.Chain_of_Resp_Pattern
{
    public class Cashier : IRequestHandler
    {
        public ApprovalStatus HandleRequest(LoanRequest req)
        {
            if (req.Amount < 1000)
                return ApprovalStatus.Approved;
            else
                return this.TrySuccessor(req);
        }

        public IRequestHandler Successor { get; set; }
    }
}
