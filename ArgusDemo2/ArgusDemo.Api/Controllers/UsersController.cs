using ArgusDemo.Api.Data;
using ArgusDemo.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArgusDemo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly DataContext dataContext;
        public UsersController(DataContext dataContext)//di
        {
            this.dataContext=dataContext;
        }

        //tüm kullanıcıları getir
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await dataContext.Users.ToListAsync();
            return Ok(users);
        }

        //id si verilen kullanıcıyı getir
        [HttpGet]
        [Route("{id=guid}")]
        [ActionName("GetAUser")]
        public async Task<IActionResult> GetAUser([FromRoute] int id)
        {
            var user = await dataContext.Users.FirstOrDefaultAsync(x=>x.UserID==id);
            if (user!=null)
            {
                return Ok(user);
            }
            return NotFound("User Not Found!");
        }

        //kullanıcı ekleme
        [HttpPost]
        public async Task<IActionResult> SaveUser([FromBody] User user)
        {
            await dataContext.Users.AddAsync(user);
            await dataContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAUser), new { id=user.UserID }, user);
        }

        //kullanıcı bilgi güncelleme
        //kullanıcı silme

        


        


    }
}
