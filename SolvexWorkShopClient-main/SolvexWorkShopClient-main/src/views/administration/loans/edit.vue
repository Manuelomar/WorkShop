<template>
  <section>
    <nav class="navbar">
      <div class="navbar-brand">
        <span class="navbar-item title is-2">Editar Usuario</span>
      </div>
      <div class="navbar-end">
        <div class="navbar-item">
          <div class="field">
            <b-switch type="is-twitter" v-model="exitOnSave"
              >Salir al guardar</b-switch
            >
          </div>
        </div>
      </div>
    </nav>
    <b-loading :is-full-page="false" :active="loading || saving"></b-loading>

    <form @submit.prevent="validate">
      <b-collapse class="card" animation="slide" aria-id="contentIdFor">
        <template #trigger="props">
          <div class="card-header" role="button" aria-controls="contentIdFor">
            <p class="card-header-title">Detalles del Del Usuario</p>
            <a class="card-header-icon">
              <b-icon :icon="props.open ? 'menu-down' : 'menu-up'"> </b-icon>
            </a>
          </div>
        </template>

        <div class="card-content">
          <div class="content">
            <div class="columns">

              <div class="column">
                <!--name-->
                <b-field
                  label="Nombre del Usuario"
                  :type="{ 'is-danger': errors.has('name') }"
                  :message="errors.first('name')"
                >
                  <b-input
                    v-model="model.name"
                    name="name"
                    data-vv-as="nombre"
                    v-validate="'required'"
                    placeholder="Requerido"
                  />
                </b-field>
                
                <!--description-->
                <b-field
                  label="lastName*"
                  :type="{ 'is-danger': errors.has('lastName') }"
                  :message="errors.first('lastName')"
                >
                  <b-input
                    v-model="model.lastName"
                    name="lastName"
                    data-vv-as="lastName"
                    v-validate="'required'"
                    placeholder="Requerido"
                  />
                </b-field>

                <!--startDate-->
        
                <b-field
                  label="Age*"
                  :type="{ 'is-danger': errors.has('Age') }"
                  :message="errors.first('Age')"
                >
                  <b-input
                    v-model="model.contentSupport"
                    name="Age"
                    data-vv-as="contenido de apoyo"
                    v-validate="'required'"
                    placeholder="Requerido"
                  />
                </b-field>

              </div>
            </div>
          </div>
        </div>
      </b-collapse>

      <br/>

      <nav class="level">
        <!-- Left side -->
        <div class="level-left">
          <p class="level-item">
            <b-button
              :disabled="(modelDoNotChange && !errors.any()) || saving"
              size="is-medium"
              type="is-light"
              @click="clean"
              icon-right="eraser"
              >Reiniciar</b-button
            >
          </p>
          <p class="level-item">
            <b-button
              size="is-medium"
              type="is-danger"
              :disabled="saving"
              @click="cancel"
              icon-right="cancel"
              >Cancelar</b-button
            >
          </p>
        </div>

        <!-- Right side -->
        <div class="level-right">
          <p class="level-item">
            <b-button
              size="is-medium"
              type="is-primary"
              native-type="submit"
              :disabled="errors.any()"
              :loading="saving"
              icon-right="content-save"
              >Guardar</b-button
            >
          </p>
        </div>
      </nav>
    </form>
  </section>
</template>


<script lang="ts">
import { Component, Mixins, Vue } from "vue-property-decorator";
import { BaseFormEditMixin } from "@/mixins";
import { WorkShop } from "@/core/model";

@Component({})
export default class UserEditComponent extends Mixins<BaseFormEditMixin<WorkShop>>(
  BaseFormEditMixin
) {
  
  constructor() {
    super();
    this.controller = "WorkShop";
    this.model = new WorkShop();
  }

  async getData() {
    try {
      if (this.modelToEdit && !this.loadFromAPI)
        this.model = this.map<WorkShop>(this.modelToEdit);
      else {
        this.loading = true;
        const response = await this.service.getById(this.id);
        this.model = response.data;
        this.model.startDate = new Date(this.model.startDate as string);
        this.model.endDate = new Date(this.model.endDate as string);
      }
      this.modelInit = this.map<WorkShop>(this.model);
    } catch (errors) {
      this.operationFailedErrors(errors);
    } finally {
      this.loading = false;
    }
  }
}
</script>

<style lang="css">
.p-2rem {
  padding: 2rem;
}
</style>