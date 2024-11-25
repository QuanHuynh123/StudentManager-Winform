using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class TrainingProgramBLL
    {
        private readonly TrainingProgramDAL _trainingProgramDAL;

        public TrainingProgramBLL()
        {
            _trainingProgramDAL = new TrainingProgramDAL();
        }

        // Lấy tất cả TrainingProgram
        public List<TrainingProgramDTO> GetAllTrainingPrograms()
        {
            return _trainingProgramDAL.GetAllTrainingPrograms();
        }

        // Thêm TrainingProgram
        public bool AddTrainingProgram(TrainingProgramDTO trainingProgram)
        {
            if (string.IsNullOrWhiteSpace(trainingProgram.ProgramName))
            {
                throw new System.ArgumentException("Program name cannot be empty.");
            }

            return _trainingProgramDAL.AddTrainingProgram(trainingProgram);
        }

        // Xóa TrainingProgram
        public bool DeleteTrainingProgram(int programID)
        {
            if (programID <= 0)
            {
                throw new System.ArgumentException("Invalid Program ID.");
            }

            return _trainingProgramDAL.DeleteTrainingProgram(programID);
        }

        // Cập nhật TrainingProgram
        public bool UpdateTrainingProgram(TrainingProgramDTO trainingProgram)
        {
            if (trainingProgram.ProgramID <= 0)
            {
                throw new System.ArgumentException("Invalid Program ID.");
            }

            if (string.IsNullOrWhiteSpace(trainingProgram.ProgramName))
            {
                throw new System.ArgumentException("Program name cannot be empty.");
            }

            return _trainingProgramDAL.UpdateTrainingProgram(trainingProgram);
        }

        // Tìm TrainingProgram theo tên
        public List<TrainingProgramDTO> SearchTrainingPrograms(string programName)
        {
            if (string.IsNullOrWhiteSpace(programName))
            {
                throw new System.ArgumentException("Program name cannot be empty.");
            }

            return _trainingProgramDAL.SearchTrainingPrograms(programName);
        }

        // Tìm TrainingProgram theo ID
        public TrainingProgramDTO FindByIdTrainingProgram(int programID)
        {
            if (programID <= 0)
            {
                throw new System.ArgumentException("Invalid Program ID.");
            }

            return _trainingProgramDAL.FindByIdTrainingProgram(programID);
        }

        public List<TrainingProgramDTO> GetTrainingProgramsByDepartmentID(int departmentID)
        {
            if (departmentID <= 0)
            {
                throw new System.ArgumentException("Invalid Department ID.");
            }

            return _trainingProgramDAL.GetTrainingProgramsByDepartmentID(departmentID);
        }

    }
}
