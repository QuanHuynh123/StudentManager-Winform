using DTO;
using DTO.Models;
using Mapster;

namespace GUI
{
    public static class MappingConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<ClassDTO, ClassForExport>.NewConfig()
                .Map(dest => dest.SubjectName, src => src.Subject.SubjectName)
                .Map(dest => dest.TeacherName, src => src.Teacher.FullName);
        }
    }
}
