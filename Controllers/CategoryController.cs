using Microsoft.AspNetCore.Mvc;

//endpoint => URl
//https://localhost:5001
//https://localhost:5001/categories
[Route("categories")]    
public class CategoryController : ControllerBase
{
    [Route("{id}")]
    public string GetById(int id)
    {
        return "GET " + id.ToString();
    }

    [HttpPost]
    [Route("")]
    public string Post()
    {
        return "Post";
    }

    [HttpPut]
    [Route("")]
    public string Put()
    {
        return "Put";
    }
    
    [HttpDelete]
    [Route("")]
    public string Delete()
    {
        return "Delete";
    }
}