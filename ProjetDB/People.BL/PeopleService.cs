namespace People.BL
{
    public class PeopleService :IPeopleService
    {
        readonly DAL.IpeopleRepository ipeopleRepository;
        public PeopleService(DAL.IpeopleRepository ipeopleRepository)
        {
            this.ipeopleRepository = ipeopleRepository;
        }   
        public List<People> getAll()
        {
            return ipeopleRepository.getAll();
        }
    }
}