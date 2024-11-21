using Microsoft.AspNetCore.Mvc;

namespace MicroserviceTest.User.Controllers;

[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<User>> GetUser()
    {
        return Ok(UserWrapper.Users);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        return Ok(UserWrapper.Users.Find(x => x.Id == id));
    }

    [HttpPost]
    public IActionResult InsertUser([FromBody] User user)
    {
        UserWrapper.Users.Add(user);
        return Created($"/api/users/{user.Id}", user);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, [FromBody] User userRequest)
    {
        var user = UserWrapper.Users.Find(x => x.Id == id);

        if (user == null)
            return NotFound();

        UserWrapper.Users.Remove(user);
        UserWrapper.Users.Add(userRequest);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveUser(int id)
    {
        var user = UserWrapper.Users.Find(x => x.Id == id);
        
        if (user == null)
            return NotFound();

        UserWrapper.Users.Remove(user);
        
        return NoContent();
    }
}
