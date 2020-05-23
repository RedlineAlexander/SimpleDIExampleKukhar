using System;
using System.Collections.Generic;
using System.Text;
/*
1)Добавьте в ваш репозиторий новое консольное приложение, 
2)скопируйте туда интерфейсы IFortuneTeller и IFortuneLoader из SimpleDiExample. 
3)Добавьте интерфейс IFortuneGetter и IFortuneFacade. 
4)В IFortuneFacade вам необходимо заинжектить IFortuneLoader и IFortuneGetter. 
5)IFortuneFacade должен содержать два метода, 
6)которые будут выводить или возвращать предсказание из IFortuneTeller
7)и IFortuneGetter соответственно. 
8)В оба и IFortuneLoader и IFortuneGetter необходимо инжектить IFortuneLoader. 
9)В Main вам с помощью Unity необходимо зарегистрировать все четыре экземпляра 
10)для каждого из интерфейсов и сделать Rezolve для IFortuneFacade. 
11)Попробуйте вызвать оба его метода.

12)Добавьте в проект с News то что на данный момент есть в моем проекте Infestation
13)+ то что мы сделали в нем на уроке. 
14)Переименуйте проект в Infestation(или в то, что по вашему усмотрению больше подходит для названия, 
15)это будет проект-инфографика количества больных вирусом на текущий момент времени, 
16)плюс будет раздел новостей). 
17)Это будет проект на который мы будем навешивать плюшки и выполнять на нем некоторые задания.
18)Поставьте все проекты в вашем репозитории с ДЗ(их должно быть 3 на данный момент) под CI.

19)На все эти проекты должен быть создан всего один проект в AppVeyor. 20)
Для этого вам придется разобратся с build matrix.
 * 
 */
namespace SimpleDIExampleKukhar.DependencyInjectionExampleKukhar
{
    //2 метода
   public interface  IFortuneTeller
    {
        public void TellFortune();
    }
}
