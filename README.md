# Azure Logic App with Content Moderation

This web application hosted in Azure is going to connect to a azure sql database and display the available tweets in a grid layout

![Tweeter Analysis web application hosted on Azure as a App service](https://github.com/hansamaligamage/azurelogicapp/blob/master/TweetAnalysis/Images/tweets.png)

You can find the sample code used to retrieve list of tweets as below,

This is the TweetsController, goint to fetch tweets from the database and order it as per the Id field. Id field is an auto increment column in the database.

```
 public class TweetsController : Controller 
    { 
        private DBContext db = new DBContext(); 
 
        // GET: Tweets 
        public ActionResult Index() 
        { 
            var tweets = db.Tweets.OrderByDescending(o => o.Id).ToList(); 
            return View(tweets); 
        }
  ```
 This is the DBContext class, it has the Tweets table and database rules has been applied to access the azure hosted sql database

```
public partial class DBContext : DbContext 
    { 
        public DBContext() 
            : base("name=DBContext") 
        { 
        } 
 
        public virtual DbSet<Tweet> Tweets { get; set; } 
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; } 
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        { 
            modelBuilder.Entity<database_firewall_rules>() 
                .Property(e => e.start_ip_address) 
                .IsUnicode(false); 
 
            modelBuilder.Entity<database_firewall_rules>() 
                .Property(e => e.end_ip_address) 
                .IsUnicode(false); 
        } 
    }
    ```
