using AutoMapper;

namespace LegalPlatform.Core.Mapping.Articales
{
    public partial class ArticaleProfile : Profile
    {
        public ArticaleProfile()
        {
            GetArticaleQueryMapping();
            WriteArticaleCommandMapping();
            UpdateArticaleCommandMapping();
        }  
    }
}
