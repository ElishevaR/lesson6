namespace People.DAL
{
    public class PeopleRepository :IpeopleRepository
    {
        readonly PeopleContext _PeopleContext;
        public PeopleRepository (PeopleContext peopleContext)
        {
            _PeopleContext = peopleContext;
        }
       public List<People> GetAll()
        {

        }
    }
}