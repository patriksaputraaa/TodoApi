namespace TodoApi.Models;

public class TodoCount{
    public int Count {set; get;}
    public List<TodoItem> DataTodoItem {get;set;}

    public TodoCount(int count, List<TodoItem> dataTodoItem){
        Count = count;
        DataTodoItem = dataTodoItem;
    }

}