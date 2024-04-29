<?php

namespace App\Models;

use Laravel\Sanctum\HasApiTokens;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;
use Illuminate\Database\Eloquent\Factories\HasFactory;

class CategoryModel extends Model
{
    use HasApiTokens, HasFactory, Notifiable;

    protected $fillable = ['description'];

    protected $primaryKey = 'id';

    protected $guarded = ['id'];

    public $timestamps = true;

    protected $hidden = ['created_at', 'updated_at'];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'categories';
}
