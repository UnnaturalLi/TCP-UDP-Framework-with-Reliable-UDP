namespace NetworkBase
{
    public class ServerBase
    {
        public virtual void OnStart(){}
        public virtual void OnStop(){}
        public virtual bool OnInit()
        {
            return true;
        }
    }
}