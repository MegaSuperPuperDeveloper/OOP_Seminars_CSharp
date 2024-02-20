namespace Seminar2.Task1;

public abstract class Actor : iActorBehaviour // Шаблон для разных видов клиентов
{
    protected String name;
    protected internal bool isTakeOrder;
    protected internal bool isMakeOrder;

    public Actor(String name) {
        this.name = name;
    }

    public abstract String getName();
    public abstract void setName(String name);

    bool iActorBehaviour.isTakeOrder()
    {
        return isTakeOrder;
    }

    bool iActorBehaviour.isMakeOrder()
    {
        return isMakeOrder;
    }

    public void setTakeOrder(bool isCreated)
    {
        isTakeOrder = isCreated;
    }

    public void setMakeOrder(bool isCreated)
    {
        isMakeOrder = isCreated;
    }

    public Actor getActor()
    {
        return this;
    }
}
