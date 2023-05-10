using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyApiNetCore6.Data;
using MyApiNetCore6.Models;

namespace MyApiNetCore6.Repositories.FormRepo
{
    public class FormRepository:IFormRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public FormRepository(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Guid> AddFormAsync(FormModel model)
        {
            var newForm = _mapper.Map<Form>(model);
            _context.Forms!.Add(newForm);
            await _context.SaveChangesAsync();

            return newForm.Id;
        }

        public async Task DeleteFormAsync(Guid id)
        {
            var deleteForm = _context.Forms!.SingleOrDefault(b => b.Id == id);
            if (deleteForm != null)
            {
                _context.Forms!.Remove(deleteForm);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<FormModel>> GetAllFormsAsync()
        {
            var Forms = await _context.Forms!.ToListAsync();
            return _mapper.Map<List<FormModel>>(Forms);
        }

        public async Task<FormModel> GetFormAsync(Guid id)
        {
            var Form = await _context.Forms!.FindAsync(id);
            return _mapper.Map<FormModel>(Form);
        }

        public async Task UpdateFormAsync(Guid id, FormModel model)
        {
            if (id == model.Id)
            {
                var updateForm = _mapper.Map<Form>(model);
                _context.Forms!.Update(updateForm);
                await _context.SaveChangesAsync();
            }
        }
    }
}
