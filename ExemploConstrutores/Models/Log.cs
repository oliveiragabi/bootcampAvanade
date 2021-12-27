namespace ExemploConstrutores.Models
{
    public class Log
    {
        private log _log;

        public string PropriedadeLog { get; set; }

        private Log()
        {

        }

        public static Log GetInstance()
        {
            if(_log == null)
            {
                _log = new log();
            }
            return _log;
        }
    }
}