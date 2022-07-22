import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class AddmovieService {
  removeAllmovie(): void {
    throw new Error('Method not implemented.');
  }


  public addmovieItemList : any =[]
  public movieList = new BehaviorSubject<any>([]);

  constructor() { }
  getMovies(){
    return this.movieList.asObservable();
  }

  setMovie(movie : any){
    this.addmovieItemList.push(...movie);
    this.movieList.next(movie);
  }
  addtoMovie(movie : any){
    this.addmovieItemList.push(movie);
    this.movieList.next(this.addmovieItemList);
    this.getTotalPrice();
    console.log(this.addmovieItemList)
  }
  getTotalPrice() : number{
    let grandTotal = 1;
    this.addmovieItemList.map((a:any)=>{
      grandTotal += a.movieFinal;
    })
    return grandTotal;
  }
  removeAddmovieItem(movie: any){
    this.addmovieItemList.map((a:any, index:any)=>{
      if(movie.id=== a.id){
        this.addmovieItemList.splice(index,1);
      }
    })
    this.movieList.next(this.addmovieItemList);
  }
  removeAllAddmovie(){
    this.addmovieItemList = []
    this.movieList.next(this.addmovieItemList);
  }
}