using Seminar2.Task1;

public interface iActorBehaviour {
    public abstract bool isTakeOrder();
    public abstract bool isMakeOrder();
    public abstract void setTakeOrder(bool isCreated);
    public abstract void setMakeOrder(bool isCreated);
    public abstract Actor getActor();
}
