using Seminar2.Task1;

public interface iMarketBehaviour // Интерфейс для входа и выхода из магазина
{
    void AcceptToMarket(iActorBehaviour actor);
    void ReleaseFromMarket(List<iActorBehaviour> actor);
    void update();
}