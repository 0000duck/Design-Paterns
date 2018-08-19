
namespace Main.Behavioral_Patterns.Chain_of_Resp_Pattern
{
    public static class RequestHandlerExtension
    {
        public static ApprovalStatus TrySuccessor(this IRequestHandler current, LoanRequest req)
        {
            if (current.Successor != null)
            {
                return current.Successor.HandleRequest(req);
            }
            else
            {
                return ApprovalStatus.Denied;
            }
        }
    }
}
