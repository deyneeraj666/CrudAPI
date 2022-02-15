using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollectionCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        static List<string> crudlst = new List<string>() { "Roffel","Ram"};

        [HttpGet]
        public List<string> getList()
        {
            return crudlst;
        }
        [HttpPost]
        public void postList(string value)
        {
            crudlst.Add(value);
        }
        [HttpPut]
        public void putList(int i,string value)
        {
            crudlst[i]=value;
        }
        [HttpDelete]
        public void deleteList(int i)
        {
            crudlst.RemoveAt(i);
        }
    }
}
