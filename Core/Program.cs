using Core.Db;
using Microsoft.EntityFrameworkCore;

var builder = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite("Data Source=DbUser.db");
using var db = new AppDbContext(builder.Options);
db.Database.EnsureCreated();

/*
var byn = new Currency { Name = "BYN" };
var usd = new Currency { Name = "USD" };
db.Currency.AddRange(byn, usd);
db.Users.Add(new User
{
    Username = "Dima",
    PasswordHash = "Test12345678",
    Wallets = new List<Wallet>
            {
                new Wallet
                {
                    Name = "Сбер",
                    Currency = byn,
                    Money = 5000,
                    TypeWallet = TypeWallet.Card,
                },
                new Wallet
                {
                    Name = "Кошелек Stan",
                    Currency = byn,
                    Money = new decimal(5.5),
                    TypeWallet = TypeWallet.Cash,
                },
            }
});
db.SaveChanges();
var transferRepository = new TransferRepository(db);
var transfer = new TransferToWallet()
{
    Comment = "Перевод БАБЛА",
    Date = DateTime.Now,
    Money = 35,
    Id = Guid.NewGuid(),
    WalletId = Guid.Parse("2C04B993-C81C-43C9-97C3-B2D6E5665325"),
    ToWalletId = Guid.Parse("B1D26A44-969A-471E-BEDE-FCB5037E44DB")
};
transferRepository.Add(transfer);

*/

