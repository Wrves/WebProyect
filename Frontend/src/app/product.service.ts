import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
//import { SERVER_URL } from './app.config.server';  // Importa la URL base del servidor

// Define la interfaz Product
interface Product {
  idProduct: number;
  productName: string;
  productDescription: string;
  price: number;
  imageProductUrl: string;
}

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private apiUrl = `http://localhost:5158/api/products`;  // Endpoint de productos

  constructor(private http: HttpClient) {}

  // Método para obtener la lista de productos
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.apiUrl);
  }
}
