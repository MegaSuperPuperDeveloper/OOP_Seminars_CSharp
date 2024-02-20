﻿using Seminar2.Task1;

public interface iQueueBehaviour // Интерфейс для взаимодействия внутри магазина
{
    void TakeInQueue(iActorBehaviour actor);
    void ReleaseFromQueue();
    void TakeOrder();
    void GiveOrder();
}