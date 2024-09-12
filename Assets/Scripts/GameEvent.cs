public class GameEvent
{
    private object[] m_list;

    //constructor, una accion que se crea siempre que se ejecuta una nueva instancia
    //informacion necesaria para crear una nueva variable




    //int x=0
    //int[] nums=new int[3]

    //nums=[10],[102],[204]

    //posicion 0,1,2
    //nums[2] es 204

    //type object arreglo coleccion de muchos objects
    public GameEvent(params object[] _list)
    {
        this.m_list = _list;
    }

    public object[] GetParameters()
    {
        //regresando un arreglo de objetos
        return m_list;
    }
}
