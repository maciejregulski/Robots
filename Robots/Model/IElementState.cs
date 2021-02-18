namespace Robots.Model
{
    public interface IElementState
    {
        void ChangeState(IRobot robot);

        void ReportState();
    }
}
