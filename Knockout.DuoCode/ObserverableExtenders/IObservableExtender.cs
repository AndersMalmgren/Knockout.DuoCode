namespace Knockout.ObserverableExtenders
{
    public interface IObservableExtender { }

    public interface IObservableExtender<T, in TOPtions> : IObservableExtender
    {
        Observable<T> Extend(Observable<T> observable, TOPtions options);
    }

    public interface IObservableExtender<T> : IObservableExtender
    {
        Observable<T> Extend(Observable<T> observable);
    }
}