using MyApiNetCore6.Models;

namespace MyApiNetCore6.Repositories.FormRepo
{
    public interface IFormRepository
    {
        public Task<List<FormModel>> GetAllFormsAsync();
        public Task<FormModel> GetFormAsync(Guid id);
        public Task<Guid> AddFormAsync(FormModel model);
        public Task UpdateFormAsync(Guid id, FormModel model);
        public Task DeleteFormAsync(Guid id);
    }
}
