<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\CategoriesController;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/

Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
    return $request->user();
});

Route::prefix('v1')->group(function () {
    Route::get('/ping', [HomeController::class, 'test']);
    Route::get('/tasks', [HomeController::class, 'list'])->name('list');
    Route::get('/tasks-completed', [HomeController::class, 'list'])->name('listcompleted');
    Route::post('/task', [HomeController::class, 'create'])->name('create');
    Route::get('/task/{id}', [HomeController::class, 'delete'])->name('delete');
    Route::patch('/task', [HomeController::class, 'update'])->name('udpate');
    Route::get('/categories', [CategoriesController::class, 'List'])->name('categories');
    Route::post('/category', [CategoriesController::class, 'create'])->name('category');
});
