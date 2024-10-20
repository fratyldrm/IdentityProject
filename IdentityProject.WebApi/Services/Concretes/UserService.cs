using IdentityProject.WebApi.Models;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Repository.Abstaracsts;
using IdentityProject.WebApi.Models.Dtos.Users.Request;






namespace IdentityProject.WebApi.Services.Concretes;

public class UserService : IUserService
{

    private IUserRepistory _userRepository;
    public UserService(IUserRepistory userRepository)
    {
        _userRepository = userRepository;
    }

    public User Add(AddUsersRequestDto dto)
    {

        User user = (User)dto;
        User created = _userRepository.Add(user);
        return created;
    }

    public User Delete(int id)
    {
        User user = _userRepository.Delete(id);
        return user;
    }

    public List<User> GetAllUsers()
    {
        return _userRepository.GetAll();
    }

    public User GetByEmail(string email)
    {
        User user = _userRepository.GetByEmail(email);
        return user;
    }

    public User GetById(int id)
    {
        User user = _userRepository.GetById(id);
        return user;
    }

    public User Update(User user)
    {
        User upadeteUsers = _userRepository.Update(user);
        return upadeteUsers;
    }
}