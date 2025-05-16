using system;
using system.collection.generic;
class Task{
public string Name{get;set;}
public string Title {get;set;}
public DataType Data {get; set;}
public string  priority {low ,midum,high}
public string Description {get;set;}
public bool IsComleted {get;set;}



public Task (string name , int priority , DataType data){
    Name=name;
    priority=priority;
    Data=data;
    Descreption=discreption;

}
}
class CompletedTask {
    public Task TaskData{get;set;}
    public CompletedTask Next{get; set;}
    task.Comletedtask=next; 
    
  
public void AddTask(string tittle , dataTime data, string priority ,string Decription, bool IsCompleted ){
    task.add=new task {
        name=name++
    }
    Task manager (){
        task.add=new task
         name=name++ 
        task.arr[tasks]
            new task=100;
            int taskcount=0;
            taskcount++;
            Task.completedHead=null ;   
            
           Console.WriteLine("تم اكمال المهمة ") 
        
        }
    }
}

public void DisplayAllTasks (){
    Console.WriteLine("جميع المهام ")
    forall(var task in tasks ){
        Console.WriteLine({task.name}.{task.prioprity}..{task.Descreption}.)
    }
}
public void deletedTask(int name){
    deletedtask=taskindex-1;
for (int i=taskindex-1<taskacount){
    taski =taski+1;
    taskcount-1=null;
    taskcount--;

       name=name++
       Console.WriteLine("تم حذف المهمة ")
    }
    else {
Console.WriteLine ("لا يوجد مهمة ")
    }
}




public void SortByPriority(){
    int n = tasks.Count ;
    for (int i=0 ; i<n-1 :i++;){
        for ( int j = 0 ; j<n-i-1 ; j++;){
            if (tasks[j].priority < tasks[j+1].priority ){
                Task temp=tasks[j];
                tasks[j]=tasks [j+1];
                tasks[j+1]=temp;

            }
        }
    }
    Console.WritrLine("تم فرز المهام حسب الاولوية");

}
public void SortByDate(){
   
if (arr == null , arr.lengh==0){
    return;
    sort taskByDate(0, taskcount-1){
    QuicksortAlgorithm(int[]arr ,int lest , int high){
        if (low<high ){
            int pivotIndex=partition(arr,low,high);
         QuicksortAlgorithm(arr , lest , pivotIndex +1 , high);
}
        }
    }
    private static int Partition (int []arr , int low , int high ){
        int n =taskhight.date 
        int pivot = arr[high ];
        int i = low-1;
        for (int j= low;j=low;j<high ;j++){
            if(task[j].date<pivot ){
                i++
                swap(arr,i,j);
            }
        }
swap(arr,i+1,high);
return i+1
    }
}


public void CompletTask (string name, priority,date ){
    Task Completedtask = Task 
    TaskTask current =completed  head;
    TaskTask previous  =null;

{
    addtask(name,priority,date){

if (taskcount>=tasklengh){
    Console.WriteLine("لم يتم العثور على المهمة ");
    return 
}}
new tasks=task count ++;
new Completedtask.next=Comleted Head;
completedtask head= new Completedtask ;


Console.WriteLine("تم اكمال المهمة ");

}}

public void Display CompletedTasks(){
    Task current=CompletedHead;

}
if (completedHead==null){
    Console.WrieLine("لا يوجد مهام للعرض ");
    
}
    Consol.WriteLine("المهام المكتملة")
}

class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
             
            {
                Console.WriteLine("\nنظام إدارة المهام");
                Console.WriteLine("1. إضافة مهمة جديدة");
                Console.WriteLine("2. عرض جميع المهام");
                Console.WriteLine("3. حذف مهمة");
                Console.WriteLine("4. فرز المهام حسب الأولوية");
                Console.WriteLine("5. فرز المهام حسب التاريخ");
                Console.WriteLineO("6.رز المهام حسب هل هي مكتملة ");
                Console.WriteLine("7.اكمال مهمة ");
                Console.WriteLine("8.عرض المهام المكتملة ");
                Console.WriteLine("9. خروج");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewTask(manager);
                        
                        break;
                    case "2":
                        manager.DisplayAllTasks();
                        break;
                    case "3":
                        DeleteTask(manager);
                        break;
                    case "4":
                        manager.SortByPriority();
                        break;
                    case "5":
                        manager.SortByDate();
                        break;
                    case "6":
                        CompleteTask(manager);
                        break;
                    case "7":
                   display CompleteTask(manager);
                   case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("اختيار غير صحيح، حاول مرة أخرى.");
                        break;
                }
            }
        }}