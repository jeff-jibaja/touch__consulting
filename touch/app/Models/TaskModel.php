<?php

namespace App\Models;

use Laravel\Sanctum\HasApiTokens;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;
use Illuminate\Database\Eloquent\Factories\HasFactory;

class TaskModel extends Model
{
    use HasApiTokens, HasFactory, Notifiable;

    protected $fillable = ['description', 'name', 'estado','categories_id','created_at', 'updated_at'];

    protected $primaryKey = 'id';

    protected $guarded = ['id'];

    public $timestamps = true;


    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'task';
}
