using QuanLySach.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {
                Id = 1,
                Title = "Tôi thấy hoa vàng trên cỏ xanh",
                AuthorName ="Nguyễn Nhật Ánh",
                Price = 1,
                Content ="Truyện kể về tuổi thơ ..."},

             new Sach {
                Id = 2,
                Title = "Pro ASP.NET MVC5",
                AuthorName ="Adam Freeman",
                Price = 3.75M,
                Content ="The ASP.NET MVC5 Framework is the latest evolution of Microsoft's..."}
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault(s => s.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
