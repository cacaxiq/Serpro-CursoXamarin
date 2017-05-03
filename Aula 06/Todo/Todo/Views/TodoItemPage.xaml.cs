using System;
using Xamarin.Forms;

namespace Todo
{
    public partial class TodoItemPage : ContentPage
    {
        TodoItemDatabase todo;
        public TodoItemPage()
        {
            InitializeComponent();
            todo = new TodoItemDatabase();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {

            var todoItem = (TodoItem)BindingContext;
            await todo.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await todo.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
        }
    }
}
