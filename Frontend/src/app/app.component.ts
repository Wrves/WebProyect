import { Component } from '@angular/core';
import { ProductListComponent } from './ProductList/product-list.component'; // Importa el componente

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ProductListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Frontend';
}
