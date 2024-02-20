using Seminar2.Task1;

public class Market : iMarketBehaviour, iQueueBehaviour // Сам супермаркет 
{

    private List<iActorBehaviour> queue;

    public Market()
    {
        this.queue = new List<iActorBehaviour>();
    }

    public void AcceptToMarket(iActorBehaviour actor)
    {
        Console.WriteLine(actor.getActor().getName() + " клиент пришел в магазин ");
        TakeInQueue(actor.getActor());
    }

    public void TakeInQueue(iActorBehaviour actor)
    {
        this.queue.Add(actor.getActor());
        Console.WriteLine(actor.getActor().getName() + " клиент добавлен в очередь ");
    }

    public void ReleaseFromMarket(List<iActorBehaviour> actors)
    {
        foreach (iActorBehaviour actor in actors)
        {
            Console.WriteLine(actor.getActor().getName() + " клиент ушел из магазина ");
            queue.Remove(actor.getActor());
        }

    }

    public void update()
    {
        TakeOrder();
        GiveOrder();
        ReleaseFromQueue();
    }

    public void GiveOrder()
    {
        foreach (iActorBehaviour actor in queue)
        {
            if (actor.isMakeOrder())
            {
                actor.setTakeOrder(true);
                Console.WriteLine(actor.getActor().getName() + " клиент получил свой заказ ");
            }
        }
    }

    public void ReleaseFromQueue()
    {
        List<iActorBehaviour> releaseActors = new List<iActorBehaviour>();
        foreach (iActorBehaviour actor in queue)
        {
            if (actor.isTakeOrder())
            {
                releaseActors.Add(actor.getActor());
                Console.WriteLine(actor.getActor().getName() + " клиент ушел из очереди ");
            }
        }

        ReleaseFromMarket(releaseActors);
    }

    public void TakeOrder()
    {
        foreach (iActorBehaviour actor in queue)
        {
            if (!actor.isMakeOrder())
            {
                actor.setMakeOrder(true);
                Console.WriteLine(actor.getActor().getName() + " клиент сделал заказ ");

            }
        }
    }
}