import { Categoria } from './categoria';

export class Libro {
    public id: string;
    public nombre: string;
    public isbn: string;
    public autorId: string;
    public autor: string;
    public listaCategorias: Categoria[];    
}

