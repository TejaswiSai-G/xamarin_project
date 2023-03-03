using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebAPIDemo : ContentPage
    {
        private const string URL = "https://jsonplaceholder.typicode.com/posts";
        //private const string URL = "http://192.168.1.6:8078/Post"; 192.168.29.225
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;

        public WebAPIDemo()
        {
            InitializeComponent();
            getData();
        }

        public async void getData()
        {
            var content = await _client.GetStringAsync(URL);
            var post = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(post);
            postsListView.ItemsSource = _posts;
        }

        //protected override async void OnAppearing()
        //{
        //    var content = await _client.GetStringAsync(URL);
        //    var post = JsonConvert.DeserializeObject<List<Post>>(content);
        //    _posts = new ObservableCollection<Post>(post);
        //    postsListView.ItemsSource = _posts;
        //    base.OnAppearing();
        //}

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Title = "Hello" + DateTime.Now.Ticks.ToString() };
            _posts.Insert(0, post);
            var content = JsonConvert.SerializeObject(post);
            await _client.PostAsync(URL, new StringContent(content));
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title += "Updated";
            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(URL, new StringContent(content));
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            await _client.DeleteAsync(URL + "/" + post.Id);
            _posts.Remove(post);

        }
    }
}
