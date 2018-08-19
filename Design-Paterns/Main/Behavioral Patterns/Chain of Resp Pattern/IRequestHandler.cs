namespace Main.Behavioral_Patterns.Chain_of_Resp_Pattern
{
    public interface IRequestHandler
    {
        ApprovalStatus HandleRequest(LoanRequest req);
        IRequestHandler Successor { get; set; }
    }
}
