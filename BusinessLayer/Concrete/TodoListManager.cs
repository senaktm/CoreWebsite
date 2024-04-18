using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TodoListManager : IGenericService<ToDoList>
    {
        ITodoListDal _todoListDal;

        public TodoListManager(ITodoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public void TAdd(ToDoList t)
        {
           _todoListDal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
           _todoListDal.Delete(t);
        }

        public List<ToDoList> TGetByFilter(Expression<Func<ToDoList, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetById(int id)
        {
            return _todoListDal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _todoListDal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _todoListDal.Update(t);
        }
    }
}
