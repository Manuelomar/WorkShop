<template>
  <section>
    <nav class="navbar">
      <div class="navbar-brand">
        <span class="navbar-item title is-2">Agregar usuario</span>
      </div>
    </nav>
    <form @submit.prevent="validate">
      <b-collapse class="card" animation="slide" aria-id="contentIdFor">
  

        <div class="card-content">
          <div class="content">
            <div class="columns">
              <div class="column is-4">
              </div>
              <div class="column">
              </div>
            </div>
          </div>
        </div>
      </b-collapse>
      <br />
      <b-collapse class="card" animation="slide" aria-id="contentIdForA11y3">
        <template #trigger="props">
          <div
            class="card-header"
            role="button"
            aria-controls="contentIdForA11y3"
          >
            <p class="card-header-title">Datos personales</p>
            <a class="card-header-icon">
              <b-icon :icon="props.open ? 'menu-down' : 'menu-up'"> </b-icon>
            </a>
          </div>
        </template>

        <div class="card-content">
          <div class="content">
            <div class="columns is-multiline">
              <div class="column">
                <b-field
                  label="Nombre*"
                  :type="{ 'is-danger': errors.has('name') }"
                  :message="errors.first('name')"
                >
                  <b-input
                    v-model="model.name"
                    name="name"
                    data-vv-as="nombre"
                    v-validate="'required'"
                    placeholder="Gabriel"
                  />
                </b-field>
              </div>
              <div class="column">
                <b-field
                  label="Apellido*"
                  :type="{ 'is-danger': errors.has('lastName') }"
                  :message="errors.first('lastName')"
                >
                  <b-input
                    v-model="model.lastName"
                    name="lastName"
                    data-vv-as="apellido"
                    v-validate="'required'"
                    placeholder="Abreu"
                  />
                </b-field>
              </div>

                     <div class="column">
                <b-field
                  label="Edad*"
                  :type="{ 'is-danger': errors.has('age') }"
                  :message="errors.first('age')"
                >
                  <b-input
                    v-model.number="model.age"
                    name="age"
                    data-vv-as="edad"
                    v-validate="'required'"
                    placeholder="15"
                  />
                </b-field>
              </div>
            </div>

            <div class="columns is-multiline">
              </div>
              <div class="column">
              </div>
            </div>

            <div class="columns is-multiline">
              <div class="column">
                  <the-mask
                    v-if="model.documentType === 0"
                    name="documentTypeValue"
                    data-vv-as="documento"
                    v-model="model.documentTypeValue"
                    :mask="'###-#######-#'"
                    v-validate="'required'"
                    type="text"
                    class="input"
                    :class="{ 'is-danger': errors.has('documentTypeValue') }"
                    placeholder="Requerido"
                  />

              </div>
            </div>
          </div>
        
      </b-collapse>
      <br />

      <nav class="level">
        <!-- Left side -->
        <div class="level-left">
          <p class="level-item">
            <b-button
              :disabled="(modelDoNotChange && !errors.any()) || saving"
              type="is-light"
              @click="clean"
              icon-right="eraser"
              >Reiniciar</b-button
            >
          </p>
          <p class="level-item">
            <b-button
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
import { BaseFormAddMixin } from "@/mixins";
import { FileService } from "@/core/services";
import { Users } from "@/core/model/users.model";
@Component
export default class UserAddComponent extends Mixins<BaseFormAddMixin<Users>>(
  BaseFormAddMixin
) {
  fileService = new FileService();
  uploading = false;
  successUpload = false;
  errorUpload = false;
  constructor() {
    super();
    this.controller = "User";
    this.model = new Users();
  }
}
</script>

<style lang="scss" scoped>
</style>
