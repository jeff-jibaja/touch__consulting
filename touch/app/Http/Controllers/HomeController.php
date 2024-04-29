<?php

namespace App\Http\Controllers;

use Carbon\Carbon;
use App\Models\TaskModel;
use Illuminate\Http\Request;

class HomeController extends Controller
{
    public function test()
    {
        return 'success';
    }

    public function List()
    {
        try {
            $data = TaskModel::select('id', 'name', 'description', 'estado', 'created_at')
                ->where('estado', 1)
                ->get();

            return response()->json($data, 200);
        } catch (\Throwable $th) {
            throw $th;
        }
    }
    public function ListCompleted()
    {
        try {
            $data = TaskModel::where('estado', 0)->get();
            return response()->json($data, 200);
        } catch (\Throwable $th) {
            //throw $th;
        }
    }

    public function create(Request $request)
    {
        try {
            $task = new TaskModel();
            $task->description = $request->input('description');
            $task->name = $request->input('name');
            $task->estado = $request->input('estado');
            $task->categories_id = $request->input('category');

            $task->save();

            return response()->json($task, 200);
        } catch (\Throwable $th) {
            //throw $th;
        }
    }

    public function delete($id)
    {
        try {
            $task = TaskModel::find($id);
            $result = $task->delete();
            return response()->json($result, 200);
        } catch (\Throwable $th) {
            //throw $th;
        }
    }

    public function update(request $request)
    {
        try {
            $task = TaskModel::find($request->input('id'));
            $task->estado = $request->input('estado');

            $result = $task->save();
            return response()->json($result, 200);
        } catch (\Throwable $th) {
            //throw $th;
        }
    }
}
