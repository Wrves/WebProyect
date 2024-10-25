import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductService } from '../product.service'; // Importa el servicio de productos

@Component({
  selector: 'app-product-list',
  standalone: true,  // Define el componente como standalone
  imports: [CommonModule], // Importa CommonModule para usar *ngFor
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: any[] = [];

  constructor(private ProductService: ProductService) {}

  ngOnInit(): void {
    this.ProductService.getProducts().subscribe(
      data => this.products = data,
      error => console.error('Error al obtener productos:', error)
    );
  }
}
