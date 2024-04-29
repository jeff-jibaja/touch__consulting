<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\CategoryModel;

class CategoriesController extends Controller
{
    public function List()
    {
        try {
            $data = CategoryModel::select('id','description')->get();
            return response()->json($data, 200);
        } catch (\Throwable $th) {
            //throw $th;
        }
    }

    public function create(Request $request)
    {
        try {
            $category = new CategoryModel();
            $category->description = $request->input('category');
            $category->save();

            return response()->json($category, 200);
        } catch (\Throwable $th) {
            //throw $th;
        }
    }
}
