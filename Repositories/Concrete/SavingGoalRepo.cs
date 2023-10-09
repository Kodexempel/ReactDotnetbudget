using JohannasReactProject.Data;
using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using JohannasReactProject.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Repositories.Concrete
{
    public class SavingGoalRepo : ISavingGoalRepo
    {
        private readonly ApplicationDbContext _context;
        public SavingGoalRepo(ApplicationDbContext context) => _context = context;
        public async Task Edit(EditSavingGoalDTO editSavingGoalDTO)
        {
            var foundSavingGoal = _context.SavingGoals.Where(x => x.Id == editSavingGoalDTO.Id).FirstOrDefault();

            foundSavingGoal.Name = editSavingGoalDTO.Name;
            foundSavingGoal.Saved = editSavingGoalDTO.Saved;
            foundSavingGoal.ToSave = editSavingGoalDTO.ToSave;

            await _context.SaveChangesAsync();
        }

        public IEnumerable<SavingGoalDTO> Get(string userId)
        {
            var returnList = new List<SavingGoalDTO>();
            var savingGoals = _context.SavingGoals.Where(x => x.User.Id == userId).ToList();
          

            foreach (var item in savingGoals)
            {
                returnList.Add(new SavingGoalDTO
                {
                    Name = item.Name,
                    Saved = item.Saved,
                    ToSave = item.ToSave
                    
                });
            }

            return returnList;
        }

        public async Task Post(SavingGoal savingGoal, string userId)
        {
            
            var person = _context.Users.Where(u => u.Id == userId).FirstOrDefault();
            savingGoal.User = person;
            _context.SavingGoals.Add(savingGoal);
            await _context.SaveChangesAsync();
        }
    }
}
