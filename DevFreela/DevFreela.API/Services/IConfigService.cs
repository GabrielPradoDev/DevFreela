namespace DevFreela.API.Services
{
    public interface IConfigService
    {
        int Getvalue();
    }

    public class ConfigService : IConfigService
    {
        private int _value;
        public int Getvalue()
        {
            _value++;

            return _value;
        }

    }
}
