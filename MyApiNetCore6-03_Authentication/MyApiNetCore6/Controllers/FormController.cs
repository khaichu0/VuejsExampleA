using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApiNetCore6.Data;
using MyApiNetCore6.Models;
using MyApiNetCore6.Repositories;
using MyApiNetCore6.Repositories.FormRepo;

namespace MyApiNetCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormRepository formRepo;

        public FormController(IFormRepository repo)
        {
            formRepo = repo;
        }

        //[HttpPost("SignUp")]
        //public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        //{
        //    var result = await formRepo.SignUpAsync(signUpModel);
        //    if (result.Succeeded)
        //    {
        //        return Ok(result.Succeeded);
        //    }

        //    return Unauthorized();
        //}

        //[HttpPost("SignIn")]
        //public async Task<IActionResult> SignIn(SignInModel signInModel)
        //{
        //    var result = await formRepo.SignInAsync(signInModel);

        //    if (string.IsNullOrEmpty(result))
        //    {
        //        return Unauthorized();
        //    }

        //    return Ok(result);
        //}
        // GET: api/Forms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormModel>>> GetForms()
        {
            var list = await formRepo.GetAllFormsAsync();
            return list;
        }

        // GET: api/Forms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormModel>> GetForm(Guid id)
        {
            var Form = await formRepo.GetFormAsync(id);

            if (Form == null)
            {
                return NotFound();
            }

            return Form;
        }

        // PUT: api/Forms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForm(Guid id, FormModel Form)
        {
            if (id != Form.Id)
            {
                return BadRequest();
            }

            //formRepo.Entry(Form).State = EntityState.Modified;

            try
            {
                await formRepo.UpdateFormAsync(id, Form);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormExists(id).Result)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Forms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Form>> PostForm(FormModel form)
        {
            
            await formRepo.AddFormAsync(form);

            return CreatedAtAction("GetForm", new { id = form.Id }, form);
        }

        // DELETE: api/Forms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForm(Guid id)
        {
            var Form = await formRepo.GetFormAsync(id);
            if (Form == null)
            {
                return NotFound();
            }

            await formRepo.DeleteFormAsync(id);

            return NoContent();
        }

        private async Task<bool> FormExists(Guid id)
        {
            var form= await formRepo.GetFormAsync(id);
            if (form != null)
            {
                return true;
            }
            return false;
        }
    }
}
