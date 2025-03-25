class BankAccount:
    def __init__(self, account_holder, balance=0.0):
        self.account_holder = account_holder
        self.balance = balance

    def deposit(self, amount):
        if amount > 0:
            self.balance += amount
            print(f"Duke depozituar ${amount}...")
        else:
            print("Shuma duhet të jetë pozitive.")

    def withdraw(self, amount):
        if amount > self.balance:
            print("Gabim: Fondet jo të mjaftueshme. Transaksioni u anulua.")
        elif amount <= 0:
            print("Shuma për tërheqje duhet të jetë pozitive.")
        else:
            self.balance -= amount
            print(f"Duke tërhequr ${amount}...")

    def display_balance(self):
        print(f"Bilanci aktual: ${self.balance:.2f}")


# Testimi i klasës
def main():
    account = BankAccount("Brajan", 1000.0)
    print(f"Pronar i Llogarisë: {account.account_holder}")
    account.display_balance()

    account.deposit(500)
    account.display_balance()

    account.withdraw(200)
    account.display_balance()

    account.withdraw(1500)  # Ky transaksion do të dështojë për shkak të fondeve jo të mjaftueshme
    account.display_balance()


if __name__ == "__main__":
    main()
