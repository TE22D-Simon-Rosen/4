//Steg 1
class Book{
    private string name;
    private int pages;

    //steg 2 / 3
    private int currentPage = 0;

    public void TurnPage(){
        currentPage += 1;
    }

    //steg 3
    public int GetCurrentPage(){
        return currentPage;
    }

    //steg 4
    public Book(string n, int p){
        name = n;
        pages = p;
    }

    //steg 5
    public string GetName(){
        return name;
    }

    public int GetPages(){
        return pages;
    }
}